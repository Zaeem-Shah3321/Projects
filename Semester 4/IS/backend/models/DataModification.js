const { DataTypes } = require('sequelize');
const sequelize = require('../config/database');

const DataModification = sequelize.define('DataModification', {
  id: { type: DataTypes.INTEGER, primaryKey: true, autoIncrement: true },
  user_id: { type: DataTypes.INTEGER },
  action_type: { type: DataTypes.STRING },
  timestamp: { type: DataTypes.DATE, defaultValue: DataTypes.NOW }
});

module.exports = DataModification;
