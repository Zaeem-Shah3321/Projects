const express = require('express');
const sequelize = require('../config/database');
const { Op } = require('sequelize');
const router = express.Router();
const MouseMovement = require('../models/MouseMovement');
router.get('/:userId', async (req, res) => {
    const { userId } = req.params;
    const { date } = req.query;
  
    try {
   
      const start = new Date(date);
      start.setHours(0, 0, 0, 0); 
  
      const end = new Date(start);
      end.setDate(start.getDate() + 1);
  
      const movements = await MouseMovement.findAll({
        where: {
          user_id: userId,
          timestamp: {
            [Op.gte]: start,
            [Op.lt]: end 
          }
        },
        order: [['timestamp', 'ASC']]
      });
  
      res.json(movements);
    } catch (err) {
      console.error(err);
      res.status(500).json({ error: "Something went wrong" });
    }
  });
router.get('/dates/:userId', async (req, res) => {
    const { userId } = req.params;
    try {
      const dates = await MouseMovement.findAll({
        where: { user_id: userId },
        attributes: [
          [sequelize.fn('DATE', sequelize.col('timestamp')), 'date']
        ],
        group: ['date'],
        raw: true
      });
      res.json(dates.map(d => d.date));
    } catch (error) {
      console.error(error);
      res.status(500).json({ error: 'Error fetching available dates' });
    }
  });


module.exports = router;
