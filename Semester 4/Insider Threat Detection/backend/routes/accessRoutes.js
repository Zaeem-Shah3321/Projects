const express = require('express');
const AccessLog = require('../models/AccessLog'); 
const router = express.Router();

router.post('/api/login', async (req, res) => {
  const { user_id,ip_address,location } = req.body;
  try {
    const accessLog = await AccessLog.create({
      user_id,
      login_time: new Date(),
      logout_time: null,
      duration: 0, 
      ip_address,
      location
    });

    res.json({ message: 'Login time recorded', accessLog });
  } catch (error) {
    console.error('Failed to record login time:', error);
    res.status(500).json({ message: 'Error recording login time' });
  }
});


router.post('/api/logout', async (req, res) => {
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

      res.json({ message: 'Logout time recorded', activeSession });
    } else {
      res.status(400).json({ message: 'No active session found for this user' });
    }
  } catch (error) {
    console.error('Failed to record logout time:', error);
    res.status(500).json({ message: 'Error recording logout time' });
  }
});
router.get('/:userId', async (req, res) => {
  const { userId } = req.params;

  try {
    const logs = await AccessLog.findAll({
      where: { user_id: userId },
      order: [['login_time', 'DESC']]
    });

    res.json(logs);
  } catch (err) {
    console.error('Error fetching access logs:', err);
    res.status(500).json({ message: 'Server Error' });
  }
});
module.exports = router;
