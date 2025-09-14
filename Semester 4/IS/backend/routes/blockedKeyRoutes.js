const express = require('express');
const router = express.Router();
const BlockedKey = require('../models/BlockedKey');
const User = require('../models/User');

router.post('/', async (req, res) => {
  try {
    const { key, userId, reason } = req.body;
    if (!key || !userId || !reason) {
      return res.status(400).json({ message: 'Key, user ID, and reason are required.' });
    }

    const user = await User.findByPk(userId);
    if (!user) return res.status(404).json({ message: 'User not found.' });

    await BlockedKey.create({ key, user_id: userId, reason });

    res.status(201).json({ message: `Key for user ${userId} has been blocked.` });
  } catch (error) {
    console.error('Error blocking key:', error);
    res.status(500).json({ message: 'Internal server error.' });
  }
});

router.get('/user/:userId', async (req, res) => {
    try {
      const { userId } = req.params;
  
      const blockedKeys = await BlockedKey.findAll({ where: { user_id: userId } });
  
      if (blockedKeys.length === 0) {
        return res.status(404).json({ message: `No blocked keys found for user ${userId}.` });
      }
  
      res.status(200).json(blockedKeys);
    } catch (error) {
      console.error('Error fetching blocked keys for user:', error);
      res.status(500).json({ message: 'Internal server error.' });
    }
  });

router.get('/', async (req, res) => {
  try {
    const blockedKeys = await BlockedKey.findAll();
    res.status(200).json(blockedKeys);
  } catch (error) {
    console.error('Error fetching blocked keys:', error);
    res.status(500).json({ message: 'Internal server error.' });
  }
});


router.put('/:id', async (req, res) => {
  try {
    const { key, reason } = req.body;
    const { id } = req.params;

    const blockedKey = await BlockedKey.findByPk(id);
    if (!blockedKey) return res.status(404).json({ message: 'Blocked key not found.' });

    blockedKey.key = key || blockedKey.key;
    blockedKey.reason = reason || blockedKey.reason;

    await blockedKey.save();

    res.status(200).json({ message: 'Blocked key updated successfully.' });
  } catch (error) {
    console.error('Error updating blocked key:', error);
    res.status(500).json({ message: 'Internal server error.' });
  }
});


router.delete('/:id', async (req, res) => {
  try {
    const { id } = req.params;

    const blockedKey = await BlockedKey.findByPk(id);
    if (!blockedKey) return res.status(404).json({ message: 'Blocked key not found.' });

    await blockedKey.destroy();

    res.status(200).json({ message: 'Blocked key deleted successfully.' });
  } catch (error) {
    console.error('Error deleting blocked key:', error);
    res.status(500).json({ message: 'Internal server error.' });
  }
});

module.exports = router;
