const { DataTypes } = require('sequelize');
const sequelize = require('../config/database');

const MouseEvent = sequelize.define('MouseEvent', {
  id: { type: DataTypes.INTEGER, primaryKey: true, autoIncrement: true },
  user_id: { type: DataTypes.INTEGER, allowNull: false },
  type: { type: DataTypes.STRING, allowNull: false }, 
  x: { type: DataTypes.FLOAT }, 
  y: { type: DataTypes.FLOAT },
  key: { type: DataTypes.STRING }, 
  timestamp: { type: DataTypes.BIGINT, allowNull: false },
}, {
  tableName: 'mouse_events',
  timestamps: true, 
});

module.exports = MouseEvent;
