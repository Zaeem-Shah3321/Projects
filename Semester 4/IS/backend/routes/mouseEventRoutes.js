const express = require('express');
const router = express.Router();
const MouseEvent = require('../models/MouseEvent');
const { Op } = require('sequelize');

router.post('/', async (req, res) => {
  try {
    const { user_id, type, x, y, key, timestamp } = req.body;
    const event = await MouseEvent.create({ user_id, type, x, y, key, timestamp });
    res.status(200).json({ message: 'Event saved successfully', event });
  } catch (error) {
    console.error('Failed to save event:', error);
    res.status(500).json({ error: 'Server error' });
  }
});


router.get('/:userId', async (req, res) => {
  const { userId } = req.params;
  const { date } = req.query;

  try {
    const selectedDate = new Date(date);
    const startOfDay = selectedDate.setHours(0, 0, 0, 0);
    const endOfDay = selectedDate.setHours(23, 59, 59, 999);

    const events = await MouseEvent.findAll({
      where: {
        user_id: userId,
        timestamp: {
          [Op.between]: [startOfDay, endOfDay], // These are bigint timestamps
        },
      },
      order: [['timestamp', 'ASC']],
    });

    res.json(events);
  } catch (err) {
    console.error(err);
    res.status(500).json({ message: 'Internal Server Error', error: err });
  }
});

module.exports = router;
