const { DataTypes } = require('sequelize');
const sequelize = require('../config/database');

const AccessLog = sequelize.define('AccessLog', {
  id: { type: DataTypes.INTEGER, primaryKey: true, autoIncrement: true },
  user_id: { type: DataTypes.INTEGER },
  login_time: { type: DataTypes.DATE },
  logout_time: { type: DataTypes.DATE },
  duration: { type: DataTypes.INTEGER },
  ip_address: { type: DataTypes.STRING },
  location: { type: DataTypes.STRING },
});

module.exports = AccessLog;
