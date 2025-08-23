#!/bin/bash
# Script for restoring the dump when the container is first started

echo "Restoring the AlvaClean_db database dump..."
mongorestore --username root --password "$MONGO_INITDB_ROOT_PASSWORD" \
  --authenticationDatabase admin \
  --db AlvaClean_db \
  /docker-entrypoint-initdb.d/mongoDump/AlvaClean_db
echo "The dump has been restored!"

