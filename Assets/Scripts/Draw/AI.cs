using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class AI : MonoBehaviour
{
    Socket sock;
    byte[] receiverBuff;

    void Start()
    {
        sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        var ep = new IPEndPoint(IPAddress.Parse("10.120.73.36"), 8080);
        sock.Connect(ep);

        receiverBuff = new byte[8192];
    }

    void Update()
    {
        byte[] buff = Encoding.UTF8.GetBytes("Hello");
        sock.Send(buff, SocketFlags.None);

        int n = sock.Receive(receiverBuff);
        string data = Encoding.UTF8.GetString(receiverBuff, 0, n);
        Debug.Log(data);
    }
}