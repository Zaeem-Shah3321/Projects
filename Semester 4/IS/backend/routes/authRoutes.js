const express = require('express');
const bcrypt = require('bcrypt');
const jwt = require('jsonwebtoken');
const User = require('../models/User');
const AccessLog = require('../models/AccessLog'); 
const BlockedIP = require('../models/BlockedIP');
const router = express.Router();


router.get('/users', async (req, res) => {
  try {
    const users = await User.findAll({}, '-password'); 
    res.json(users);
  } catch (err) {
    console.error('Error fetching users:', err);
    res.status(500).json({ message: 'Server Error' });
  }
});



router.post('/register', async (req, res) => {
  const { username, email, password, ip_address, location } = req.body;
  try {
    const existingUser = await User.findOne({ where: { email } });
    if (existingUser) {
      return res.status(400).json({ message: 'User already exists' });
    }
    const newUser = await User.create({ username, email, password, ip_address, location });
    await AccessLog.create({
      user_id: newUser.id,
      login_time: new Date(),
      logout_time: null, 
      duration: 0, 
      ip_address,
      location
    });

    res.status(201).json({ message: 'User registered successfully', user: newUser });
  } catch (error) {
    console.error(error);
    res.status(500).json({ message: 'Something went wrong!' });
  }
});

// User Login
router.post('/login', async (req, res) => {
  const { email, password,ip_address,location } = req.body;

  try {
    const userIp =ip_address;
    const blocked = await BlockedIP.findOne({ where: { ip_address: userIp } });
    console.log(blocked)
    if (blocked) {
      return res.status(403).json({ message: 'Your IP address has been blocked.' });
    }
    const user = await User.findOne({ where: { email } });
    if (!user) {
      return res.status(400).json({ message: 'User not found' });
    }
    if (user.blocked) {
      return res.status(403).json({ message: 'Your account has been blocked. Please contact support.' });
    }
    
    const isMatch = await bcrypt.compare(password, user.password);
    if (!isMatch) {
      return res.status(400).json({ message: 'Invalid credentials' });
    }

    const token = jwt.sign({ userId: user.id, email: user.email }, 'your_secret_key', { expiresIn: '1h' });

    const accessLog = await AccessLog.create({
      user_id: user.id,
      login_time: new Date(),
      logout_time: null,  
      duration: 0, 
      ip_address,
      location
    });
    let user_id =user.id;
    res.status(200).json({ message: 'Login successful', token,user_id });

  } catch (error) {
    console.error(error);
    res.status(500).json({ message: 'Something went wrong!' });
  }
});


router.post('/logout', async (req, res) => {
  const { user_id } = req.body;

  try {
    const activeSession = await AccessLog.findOne({
      where: {
        user_id: user_id,
        logout_time: null
      },
      order: [['id', 'DESC']],
    });

    if (activeSession) {
      const logout_time = new Date();
      const duration = Math.floor((logout_time - activeSession.login_time) / 1000);


      await activeSession.update({
        logout_time,
        duration,
      });

      res.status(200).json({ message: 'Logout successful', activeSession });
    } else {
      res.status(400).json({ message: 'No active session found for this user' });
    }
  } catch (error) {
    console.error(error);
    res.status(500).json({ message: 'Error updating logout time' });
  }
});

router.post('/logout', async (req, res) => {
    const { user_id } = req.body; 
    const logoutTime = new Date().toISOString(); 

    try {
        const accessLog = await AccessLog.findOne({
            where: {
                user_id,
                logout_time: null, 
            },
            order: [['login_time', 'DESC']], 
        });

        if (!accessLog) {
            return res.status(400).json({ message: 'No active session found for this user.' });
        }


        const loginTime = new Date(accessLog.login_time).getTime();
        const logoutTimestamp = new Date(logoutTime).getTime();
        const sessionDuration = Math.floor((logoutTimestamp - loginTime) / 1000); 
        accessLog.logout_time = logoutTime;
        accessLog.duration = sessionDuration;

        await accessLog.save(); 

        res.status(200).json({ message: 'Logout successful, session duration updated.' });
    } catch (error) {
        console.error(error);
        res.status(500).json({ message: 'Something went wrong!' });
    }
});



router.post('/admin/block-user/:id', async (req, res) => {
  try {
    const userId = req.params.id;
    await User.update({ blocked: true }, { where: { id: userId } });
    res.json({ message: 'User has been blocked.' });
  } catch (error) {
    console.error(error);
    res.status(500).json({ message: 'Error blocking user.' });
  }
});


router.post('/admin/unblock-user/:id', async (req, res) => {
  try {
    const userId = req.params.id;
    await User.update({ blocked: false }, { where: { id: userId } });
    res.json({ message: 'User has been unblocked.' });
  } catch (error) {
    console.error(error);
    res.status(500).json({ message: 'Error unblocking user.' });
  }
});

module.exports = router;
