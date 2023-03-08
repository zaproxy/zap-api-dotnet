using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace OWASPZAPDotNetAPI.Tests
{
    [TestClass]
    public class ClientApiTests
    {
        private ClientApi zap;

        [TestInitialize]
        public void InstantiateClientApi()
        {
            zap = new ClientApi("127.0.0.1", 7070, "on6qbod07ssf92587pme6rd5u8");
        }

        [TestCleanup]
        public void DisposeClientApi()
        {
            zap.Dispose();
        }

        [TestMethod]
        public void When_CallApi_Is_Called_IApiResponse_IsReturned()
        {
            var response = zap.CallApi("authentication", "view", "getSupportedAuthenticationMethods", null);
            Assert.IsInstanceOfType(response, typeof(IApiResponse));
        }

        [TestMethod]
        public void When_CallApi_getSupportedAuthenticationMethods_Is_Called_ApiResponseList_IsReturned()
        {
            var response = zap.CallApi("authentication", "view", "getSupportedAuthenticationMethods", null);
            Assert.IsInstanceOfType(response, typeof(ApiResponseList));
        }

        [TestMethod]
        public void When_CallApi_getSupportedAuthenticationMethods_Is_Called_ApiResponseList_With_formBasedAuthentication_IsReturned()
        {
            var response = zap.CallApi("authentication", "view", "getSupportedAuthenticationMethods", null);
            bool formBasedAuthenticationFound = false;
            ApiResponseList apiResponseList = (ApiResponseList)response;            
            foreach (var item in apiResponseList.List)
            {
                var apiResponseElement = (ApiResponseElement)item;
                if (apiResponseElement.Value == "formBasedAuthentication")
                {
                    formBasedAuthenticationFound = true;
                    break;
                }
            }
            Assert.IsTrue(formBasedAuthenticationFound);
        }

        [TestMethod]
        public void When_CallApi_alerts_Is_Called_ApiResponseList_Is_Returned()
        {
            var response = zap.CallApi("core", "view", "alerts", null);
            ApiResponseList apiResponseList = (ApiResponseList)response;
            Assert.IsInstanceOfType(response, typeof(ApiResponseList));
        }

        [TestMethod]
        public void When_CallApi_scanners_Is_Called_ApiResponseList_WithApiResponseSet_IsReturned()
        {
            var response = zap.CallApi("pscan", "view", "scanners", null);
            Assert.IsInstanceOfType(response, typeof(ApiResponseList));
            Assert.IsInstanceOfType(((ApiResponseList)response).List[0], typeof(ApiResponseSet));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void When_CallApi_authentication_With_NonExistantMethod_Is_Called_Exception_Thrown()
        {
            try
            {
                IApiResponse response = zap.CallApi("authentication", "view", "aaaa", null);

            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "bad_view");
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void When_Api_getForcedUser_With_NonExistantContext_Is_Called_Exception_Thrown()
        {
            try
            {
                IApiResponse response = zap.forcedUser.getForcedUser("-1");

            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "context_not_found");
                throw;
            }
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void When_Api_setMode_With_NonAllowedValue_Is_Called_Exception_Thrown()
        {
            try
            {
                IApiResponse response = zap.core.setMode("ModeThatDoentExist");
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "illegal_parameter");
                throw;
            }
        }

        [TestMethod]
        public void When_Api_setMode_With_Standard_Is_Called_ApiResponse_OK_Is_Returned()
        {
            IApiResponse response = zap.core.setMode("Standard");
            Assert.AreEqual("OK", ((ApiResponseElement)response).Value);
        }

        [TestMethod]
        public void When_Api_stopAllScans_Is_Called_ApiResponse_OK_Is_Returned()
        {
            IApiResponse response = zap.spider.stopAllScans();
            Assert.AreEqual("OK", ((ApiResponseElement)response).Value);
        }
    }
}
