using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrustAllCertPolicy;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			SslPolicy sslPolicy = new SslPolicy();

			ServicePoint srvPoint = null;

			X509Certificate certificate = new X509Certificate();
			WebRequest request = null;
			int certificateProblem = 0;


			bool result = sslPolicy.CheckValidationResult(srvPoint, certificate, request, certificateProblem);

		}
	}
}
