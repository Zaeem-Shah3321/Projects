// models/SampleData.js
const { DataTypes } = require('sequelize');
const sequelize = require('../config/database');

const SampleData = sequelize.define('SampleData', {
  id: { type: DataTypes.INTEGER, primaryKey: true, autoIncrement: true },
  name: { type: DataTypes.STRING },
  value: { type: DataTypes.STRING }
});

module.exports = SampleData;
