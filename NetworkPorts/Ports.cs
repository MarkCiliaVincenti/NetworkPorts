namespace NetworkPorts
{
    /// <summary>
    /// Enumeration for common network ports
    /// </summary>
    public enum NetworkPort : int
    {
        /// <summary>
        /// File Transfer Protocol (FTP) data transfer
        /// </summary>
        FtpData = 20,
        /// <summary>
        /// File Transfer Protocol (FTP) control (command)
        /// </summary>
        FtpControl = 21,
        /// <summary>
        /// Secure Shell (SSH)
        /// </summary>
        Ssh = 22,
        /// <summary>
        /// Telnet protocol
        /// </summary>
        Telnet = 23,
        /// <summary>
        /// Simple Mail Transfer Protocol (SMTP)
        /// </summary>
        Smtp = 25,
        /// <summary>
        /// Domain Name System (DNS)
        /// </summary>
        Dns = 53,
        /// <summary>
        /// Dynamic Host Configuration Protocol (DHCP) client
        /// </summary>
        DhcpClient = 67,
        /// <summary>
        /// Bootstrap Protocol (BOOTP) server
        /// </summary>
        BootpServer = 67,
        /// <summary>
        /// Dynamic Host Configuration Protocol (DHCP) server
        /// </summary>
        DhcpServer = 68,
        /// <summary>
        /// Bootstrap Protocol (BOOTP) client
        /// </summary>
        BootpClient = 68,
        /// <summary>
        /// Trivial File Transfer Protocol (TFTP)
        /// </summary>
        Tftp = 69,
        /// <summary>
        /// Hypertext Transfer Protocol (HTTP)
        /// </summary>
        Http = 80,
        /// <summary>
        /// Post Office Protocol, version 2 (POP2)
        /// </summary>
        Pop2 = 109,
        /// <summary>
        /// Post Office Protocol, version 3 (POP3)
        /// </summary>
        Pop3 = 110,
        /// <summary>
        /// Network News Transfer Protocol (NNTP)
        /// </summary>
        Nntp = 119,
        /// <summary>
        /// Network Time Protocol (NTP)
        /// </summary>
        Ntp = 123,
        /// <summary>
        /// NetBIOS Name Service
        /// </summary>
        NetBiosNameService = 137,
        /// <summary>
        /// NetBIOS Datagram Service
        /// </summary>
        NetBiosDatagramService = 138,
        /// <summary>
        /// NetBIOS Session Service
        /// </summary>
        NetBiosSessionService = 139,
        /// <summary>
        /// Internet Message Access Protocol (IMAP)
        /// </summary>
        Imap = 143,
        /// <summary>
        /// Simple Network Management Protocol (SNMP)
        /// </summary>
        Snmp = 161,
        /// <summary>
        /// Simple Network Management Protocol Trap (SNMPTRAP)
        /// </summary>
        SnmpTrap = 162,
        /// <summary>
        /// Internet Relay Chat (IRC)
        /// </summary>
        Irc = 194,
        /// <summary>
        /// SNMP Unix Multiplexer (SMUX)
        /// </summary>
        Smux = 199,
        /// <summary>
        /// Lightweight Directory Access Protocol (LDAP)
        /// </summary>
        Ldap = 389,
        /// <summary>
        /// Hypertext Transfer Protocol Secure (HTTPS)
        /// </summary>
        Https = 443,
        /// <summary>
        /// FTP over TLS/SSL Protocol (FTPS) data transfer
        /// </summary>
        FtpsData = 989,
        /// <summary>
        /// FTP over TLS/SSL Protocol (FTPS) control (command)
        /// </summary>
        FtpsControl = 990,
        /// <summary>
        /// Microsoft Terminal Server (RDP)
        /// </summary>
        Rdp = 3389
    }
}
