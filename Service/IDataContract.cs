using System.ServiceModel;

namespace Service
{
    [ServiceContract]
    public interface IDataContract
    {
        [OperationContract]
        RegistrationResponse Registration(RegistrationRequest registration);

        [OperationContract]
        AutorizationResponse Autorization(AutorizationRequest autorization);

        [OperationContract]
        string Recording(RecordingRequest recording);
    }
}
