using Service.Requests;
using Service.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Service
{
    [ServiceContract]
    public interface IServiceContract
    {
        [OperationContract]
        RegistrationResponse Registration(RegistrationRequest registration);

        [OperationContract]
        AutorizationResponse Autorization(AutorizationRequest autorization);

        [OperationContract]
        string Recording(RecordingRequest recording);
    }
}
