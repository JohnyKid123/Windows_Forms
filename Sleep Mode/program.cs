using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;

Thread.Sleep(10000);
[DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

SetSuspendState(true, true, true);
//Process.Start("sleep", "/s   /t 0");
