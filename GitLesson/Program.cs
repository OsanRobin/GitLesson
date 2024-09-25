using System.Diagnostics;

ProcessStartInfo startInfo = new ProcessStartInfo("git.exe");

startInfo.UseShellExecute = false;
startInfo.WorkingDirectory = "dir Here";
startInfo.RedirectStandardInput = true;
startInfo.RedirectStandardOutput = true;
startInfo.Arguments = "rev-parse --abbrev-ref HEAD";

Process process = new Process();
process.StartInfo = startInfo;
process.Start();

string branchname = process.StandardOutput.ReadLine();
Console.WriteLine(branchname);