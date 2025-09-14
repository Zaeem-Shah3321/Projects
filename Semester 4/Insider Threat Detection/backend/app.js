const express = require('express');
const app = express();
const cors = require('cors');
const helmet = require('helmet');
const sequelize = require('./config/database');
const authRoutes  = require('./routes/authRoutes');
const keystrokeRoutes = require('./routes/keyRoutes');
const mouseRoutes = require('./routes/mouseRoutes');
const sampleDataRoutes = require('./routes/sampleDataRoutes');
const accessLogRoutes = require('./routes/accessRoutes'); 
const blockedIpRoutes = require('./routes/BlockedIPRoutes');
const blockedkeysRoutes=require('./routes/blockedKeyRoutes')
const mouseMovementRoutes=require('./routes/mouseMovementRoutes')
const mouseEventRoutes = require('./routes/mouseEventRoutes');

require('dotenv').config();

app.use(express.json());
app.use(cors());
app.use(helmet());

app.use('/api/mouse', mouseRoutes);
app.use('/api/auth', authRoutes);
app.use('/api/keystroke', keystrokeRoutes);
app.use('/api/sample-data', sampleDataRoutes);
app.use('/api/access-logs', accessLogRoutes);
app.use('/api/block-ip', blockedIpRoutes);
app.use('/api/blocked-keys', blockedkeysRoutes);
app.use('/api/mouse-events', mouseEventRoutes);
app.use('/api/mouse-movements', mouseMovementRoutes);

sequelize.sync().then(() => {
  console.log('Database synced');
  app.listen(5000, () => console.log(`Server running...`));
});
