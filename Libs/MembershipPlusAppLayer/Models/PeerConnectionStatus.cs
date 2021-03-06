﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CryptoGateway.RDB.Data.MembershipPlus;

namespace Archymeta.Web.MembershipPlus.AppLayer.Models
{
    public enum PeerStatus
    {
        DeadEnd,
        InBlackList,
        LeaveMessage,
        DoNotDisturb,
        NotifyButBlock,
        Notifiable,
        Connected
    }

    public enum PeerResponse
    {
        Rejected,
        RejectLeaveMessage,
        Busy,
        BusyLeaveMessage,
        Wait,
        Connecting,
        Connected
    }

    public class ConnectionStatus
    {
        public PeerStatus status = PeerStatus.DeadEnd;
        public MemberCallback me;
        public MemberCallback peer = null;
        public MemberCallback peerNotifier = null;
        public string noticeMsg;
        public string noticeType;
        public string noticeRecId;
    }
}
