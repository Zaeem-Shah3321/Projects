const { DataTypes } = require('sequelize');
const sequelize = require('../config/database');

const BlockedKey = sequelize.define('BlockedKey', {
  id: { type: DataTypes.INTEGER, primaryKey: true, autoIncrement: true },
  key: { type: DataTypes.STRING },
  user_id: { type: DataTypes.INTEGER, references: { model: 'Users', key: 'id' } }, 
  reason: { type: DataTypes.STRING },
  timestamp: { type: DataTypes.DATE, defaultValue: DataTypes.NOW }
});

module.exports = BlockedKey;
