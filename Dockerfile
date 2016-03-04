FROM resin/raspberrypi2-node

COPY node/device/samples/package.json /app/package.json
WORKDIR /app
RUN npm install --production --unsafe-perm
COPY node/device/samples/remote_monitoring.js /app/index.js
CMD node index.js
