const express = require('express');
const router = express.Router();
const Keystroke = require('../models/KeyStroke');
const { Op } = require('sequelize');

router.post('/', async (req, res) => {
  try {
    const { user_id, pattern } = req.body;

    const newKeystroke = await Keystroke.create({
      user_id,
      pattern
    });

    res.status(201).json({ message: 'Keystroke data saved!', data: newKeystroke });
  } catch (error) {
    console.error('Error saving keystroke:', error);
    res.status(500).json({ message: 'Failed to save keystroke' });
  }
});
router.get('/keystroke/:userId', async(req, res) => {
  const { userId } = req.params;
  
  console.log(`Fetching keystrokes for user: ${userId}`);
  const newKeystroke = await Keystroke.findAll({ where: { user_id: userId },});
  const userKeystrokes = newKeystroke;

  if (!userKeystrokes) {
    return res.status(404).json({ message: 'Keystrokes not found for this user' });
  }

  res.json(userKeystrokes);
});
router.get('/date/:userId', async (req, res) => {
  const { userId } = req.params;
  const { date } = req.query;

  try {
    const where = { user_id: userId };

    if (date) {
      const start = new Date(date);
      const end = new Date(date);
      end.setHours(23, 59, 59, 999);

      where.timestamp = { [Op.between]: [start, end] };
    }

    const keystrokes = await Keystroke.findAll({ where });

    if (!keystrokes || keystrokes.length === 0) {
      return res.status(404).json({ message: 'No keystrokes found for this user/date' });
    }

    res.json(keystrokes);
  } catch (error) {
    console.error('Error fetching keystrokes:', error);
    res.status(500).json({ message: 'Server error' });
  }
});

module.exports = router;
