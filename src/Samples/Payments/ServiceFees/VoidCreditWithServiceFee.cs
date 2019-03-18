﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CyberSource.Api;
using CyberSource.Model;

namespace Cybersource_rest_samples_dotnet.Samples.Payments.ServiceFees
{
    public class VoidCreditWithServiceFee
    {
        public static void Run()
        {
            var creditWithServiceFeeId = CreditWithServiceFee.Run().Id;

            var clientReferenceInformationObj = new Ptsv2paymentsidreversalsClientReferenceInformation("test_credit_void");
            var requestBody = new VoidCreditRequest(clientReferenceInformationObj);

            try
            {
                var configDictionary = new Configuration().GetConfiguration();
                var clientConfig = new CyberSource.Client.Configuration(merchConfigDictObj: configDictionary);
                var apiInstance = new VoidApi(clientConfig);

                var result = apiInstance.VoidCredit(requestBody, creditWithServiceFeeId);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception on calling the API: " + e.Message);
            }
        }
    }
}
