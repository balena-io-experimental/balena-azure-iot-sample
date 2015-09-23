using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeviceExplorerPortal.Models
{
    public class DeviceEntity
    {
        public string Id { get; set; }
        public string PrimaryKey { get; set; }
        public string SecondaryKey { get; set; }
        public string ConnectionString { get; set; }
        public string ConnectionState { get; set; }
        public DateTime LastActivityTime { get; set; }
        public DateTime LastConnectionStateUpdatedTime { get; set; }
        public DateTime LastStateUpdatedTime { get; set; }
        public int MessageCount { get; set; }
        public string State { get; set; }
        public string SuspensionReason { get; set; }

        public override string ToString()
        {
            return String.Format("Device ID = {0}, Primary Key = {1}, Secondary Key = {2}, ConnectionString = {3}, ConnState = {4}, ActivityTime = {5}, LastConnState = {6}, LastStateUpdatedTime = {7}, MessageCount = {8}, State = {9}, SuspensionReason = {10}\r\n",
                        this.Id,
                        this.PrimaryKey,
                        this.SecondaryKey,
                        this.ConnectionString,
                        this.ConnectionState,
                        this.LastActivityTime,
                        this.LastConnectionStateUpdatedTime,
                        this.LastStateUpdatedTime,
                        this.MessageCount,
                        this.State,
                        this.SuspensionReason);
        }
    }
}