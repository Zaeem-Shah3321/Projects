const express = require('express');
const router = express.Router();
const BlockedIP = require('../models/BlockedIP');

// Block an IP
router.post('/', async (req, res) => {
  try {
    const { ip, reason } = req.body;
    if (!ip || !reason) {
      return res.status(400).json({ message: 'IP address and reason are required.' });
    }

    await BlockedIP.create({ ip_address: ip, reason });

    res.status(201).json({ message: `IP ${ip} has been blocked.` });
  } catch (error) {
    console.error('Error blocking IP:', error);
    res.status(500).json({ message: 'Internal server error.' });
  }
});

// Get all blocked IPs
router.get('/', async (req, res) => {
  try {
    const blockedIps = await BlockedIP.findAll();
    res.status(200).json(blockedIps);
  } catch (error) {
    console.error('Error fetching blocked IPs:', error);
    res.status(500).json({ message: 'Internal server error.' });
  }
});

// Update a blocked IP
router.put('/:id', async (req, res) => {
  try {
    const { ip, reason } = req.body;
    const { id } = req.params;

    const blockedIP = await BlockedIP.findByPk(id);
    if (!blockedIP) return res.status(404).json({ message: 'Blocked IP not found.' });

    blockedIP.ip_address = ip || blockedIP.ip_address;
    blockedIP.reason = reason || blockedIP.reason;

    await blockedIP.save();

    res.status(200).json({ message: 'Blocked IP updated successfully.' });
  } catch (error) {
    console.error('Error updating blocked IP:', error);
    res.status(500).json({ message: 'Internal server error.' });
  }
});

// Delete a blocked IP
router.delete('/:id', async (req, res) => {
  try {
    const { id } = req.params;

    const blockedIP = await BlockedIP.findByPk(id);
    if (!blockedIP) return res.status(404).json({ message: 'Blocked IP not found.' });

    await blockedIP.destroy();

    res.status(200).json({ message: 'Blocked IP deleted successfully.' });
  } catch (error) {
    console.error('Error deleting blocked IP:', error);
    res.status(500).json({ message: 'Internal server error.' });
  }
});

module.exports = router;
