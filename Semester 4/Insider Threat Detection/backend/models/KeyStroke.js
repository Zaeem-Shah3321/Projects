const { DataTypes } = require('sequelize');
const sequelize = require('../config/database');

const Keystroke = sequelize.define('Keystroke', {
  id: { type: DataTypes.INTEGER, primaryKey: true, autoIncrement: true },
  user_id: { type: DataTypes.INTEGER },
  pattern: { type: DataTypes.TEXT },
  timestamp: { type: DataTypes.DATE, defaultValue: DataTypes.NOW }
});

module.exports = Keystroke;
