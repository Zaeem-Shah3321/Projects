const { DataTypes } = require('sequelize');
const sequelize = require('../config/database');

const BlockedIP = sequelize.define('BlockedIP', {
  id: { type: DataTypes.INTEGER, primaryKey: true, autoIncrement: true },
  ip_address: { type: DataTypes.STRING },
  reason: { type: DataTypes.STRING },
  timestamp: { type: DataTypes.DATE, defaultValue: DataTypes.NOW }
});

module.exports = BlockedIP;
