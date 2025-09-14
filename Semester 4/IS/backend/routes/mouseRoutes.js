const express = require('express');
const router = express.Router();
const MouseMovement = require('../models/MouseMovement');

router.post('/', async (req, res) => {
  try {
    const { user_id, x, y } = req.body;
    await MouseMovement.create({ user_id, x, y });
    res.status(200).json({ message: 'Mouse movement saved' });
  } catch (error) {
    console.error('Error saving mouse movement:', error);
    res.status(500).json({ message: 'Error saving mouse movement' });
  }
});

module.exports = router;
