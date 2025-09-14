const express = require('express');
const router = express.Router();
const SampleData = require('../models/SampleData');
const DataModification = require('../models/DataModification');


router.get('/', async (req, res) => {
  const data = await SampleData.findAll();
  res.json(data);
});


router.post('/', async (req, res) => {
  const { name, value, user_id } = req.body;
  const newData = await SampleData.create({ name, value });

  await DataModification.create({
    user_id,
    action_type: `Created record with ID ${newData.id} with name ${newData.name} and with value ${newData.value}`
  });

  res.status(201).json(newData);
});


router.put('/:id', async (req, res) => {
  const { name, value, user_id } = req.body;
  const { id } = req.params;

  await SampleData.update({ name, value }, { where: { id } });

  await DataModification.create({
    user_id,
    action_type: `Updated record with ID ${id}  with name ${name} and with value ${value}`
  });

  res.json({ message: 'Record updated' });
});


router.delete('/:id', async (req, res) => {
  const { id } = req.params;
  const { user_id } = req.body;

  await SampleData.destroy({ where: { id } });

  await DataModification.create({
    user_id,
    action_type: `Deleted record with ID ${id}`
  });

  res.json({ message: 'Record deleted' });
});

router.get('/user/:userId', async (req, res) => {
  const { userId } = req.params;

  try {
    const modifications = await DataModification.findAll({
      where: { user_id: userId },
      order: [['createdAt', 'DESC']]
    });

    const changes = modifications.map(mod => ({
      description: mod.action_type
    }));

    res.json({ changes });
  } catch (error) {
    console.error('Error fetching user changes:', error);
    res.status(500).json({ message: 'Internal server error' });
  }
});

module.exports = router;
