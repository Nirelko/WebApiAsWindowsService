using System;
using System.IO;
using System.ServiceProcess;

public class TestSevice : ServiceBase
{
    public TestSevice()
    {
        ServiceName = "TestService";
    }

    protected override void OnStart(string[] args)
    {
    }

    protected override void OnStop()
    {
    }
}
