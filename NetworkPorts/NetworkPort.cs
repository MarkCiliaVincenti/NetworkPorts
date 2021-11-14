﻿namespace NetworkPorts
{
    /// <summary>
    /// Class for commonly-used network port constants
    /// </summary>
    public static class NetworkPort
    {
        /// <summary>
        /// File Transfer Protocol (FTP) data transfer
        /// </summary>
        public const ushort FtpData = 20;

        /// <summary>
        /// File Transfer Protocol (FTP) control (command)
        /// </summary>
        public const ushort FtpControl = 21;

        /// <summary>
        /// Secure Shell (SSH)
        /// </summary>
        public const ushort Ssh = 22;

        /// <summary>
        /// Telnet protocol
        /// </summary>
        public const ushort Telnet = 23;

        /// <summary>
        /// Simple Mail Transfer Protocol (SMTP)
        /// </summary>
        public const ushort Smtp = 25;

        /// <summary>
        /// Domain Name System (DNS)
        /// </summary>
        public const ushort Dns = 53;

        /// <summary>
        /// Dynamic Host Configuration Protocol (DHCP) client
        /// </summary>
        public const ushort DhcpClient = 67;

        /// <summary>
        /// Bootstrap Protocol (BOOTP) server
        /// </summary>
        public const ushort BootpServer = 67;

        /// <summary>
        /// Dynamic Host Configuration Protocol (DHCP) server
        /// </summary>
        public const ushort DhcpServer = 68;

        /// <summary>
        /// Bootstrap Protocol (BOOTP) client
        /// </summary>
        public const ushort BootpClient = 68;

        /// <summary>
        /// Trivial File Transfer Protocol (TFTP)
        /// </summary>
        public const ushort Tftp = 69;

        /// <summary>
        /// Hypertext Transfer Protocol (HTTP)
        /// </summary>
        public const ushort Http = 80;

        /// <summary>
        /// Post Office Protocol, version 2 (POP2)
        /// </summary>
        public const ushort Pop2 = 109;

        /// <summary>
        /// Post Office Protocol, version 3 (POP3)
        /// </summary>
        public const ushort Pop3 = 110;

        /// <summary>
        /// Network News Transfer Protocol (NNTP)
        /// </summary>
        public const ushort Nntp = 119;

        /// <summary>
        /// Network Time Protocol (NTP)
        /// </summary>
        public const ushort Ntp = 123;

        /// <summary>
        /// NetBIOS Name Service
        /// </summary>
        public const ushort NetBiosNameService = 137;

        /// <summary>
        /// NetBIOS Datagram Service
        /// </summary>
        public const ushort NetBiosDatagramService = 138;

        /// <summary>
        /// NetBIOS Session Service
        /// </summary>
        public const ushort NetBiosSessionService = 139;

        /// <summary>
        /// Internet Message Access Protocol (IMAP)
        /// </summary>
        public const ushort Imap = 143;

        /// <summary>
        /// Simple Network Management Protocol (SNMP)
        /// </summary>
        public const ushort Snmp = 161;

        /// <summary>
        /// Simple Network Management Protocol Trap (SNMPTRAP)
        /// </summary>
        public const ushort SnmpTrap = 162;

        /// <summary>
        /// Internet Relay Chat (IRC)
        /// </summary>
        public const ushort Irc = 194;

        /// <summary>
        /// SNMP Unix Multiplexer (SMUX)
        /// </summary>
        public const ushort Smux = 199;

        /// <summary>
        /// Lightweight Directory Access Protocol (LDAP)
        /// </summary>
        public const ushort Ldap = 389;

        /// <summary>
        /// Hypertext Transfer Protocol Secure (HTTPS)
        /// </summary>
        public const ushort Https = 443;

        /// <summary>
        /// FTP over TLS/SSL Protocol (FTPS) data transfer
        /// </summary>
        public const ushort FtpsData = 989;

        /// <summary>
        /// FTP over TLS/SSL Protocol (FTPS) control (command)
        /// </summary>
        public const ushort FtpsControl = 990;

        /// <summary>
        /// Microsoft Terminal Server (RDP)
        /// </summary>
        public const ushort Rdp = 3389;
    }
}
