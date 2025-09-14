const { DataTypes } = require('sequelize');
const sequelize = require('../config/database');

const MouseMovement = sequelize.define('MouseMovement', {
  id: { type: DataTypes.INTEGER, primaryKey: true, autoIncrement: true },
  user_id: { type: DataTypes.INTEGER },
  x: { type: DataTypes.FLOAT },
  y: { type: DataTypes.FLOAT },
  timestamp: { type: DataTypes.DATE, defaultValue: DataTypes.NOW }
});

module.exports = MouseMovement;
