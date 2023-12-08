using Service.Entites;
using Service.Requests;
using Service.Responses;
using System.Linq;
using System.ServiceModel;

namespace Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceContext : IServiceContract
    {

        Context db = new Context();
        public AutorizationResponse Autorization(AutorizationRequest autorization)
        {
            var result = db.users.Where(p => p.login == autorization.login);
            if (result == null)
            {
                return new AutorizationResponse { errMessage = "Такой пользователь с данным логином не найден!", error = true };
            }
            var resultPassword = result.Where(p => p.password == autorization.password);
            if (resultPassword == null)
            {
                return new AutorizationResponse { errMessage = "Введен неверный пароль!", error = true };
            }
            return new AutorizationResponse { };
        }

        public string Recording(RecordingRequest recording)
        {
            var result = db.masters.Where(p => p.name == recording.master);
            result = result.Where(p => p.record.dateTime == recording.dateTime);
            if (result != null)
            {
                return "Это время уже занято!";
            }
            Record record = new Record() { dateTime = recording.dateTime };
            Master master = new Master { name = recording.master, record = record };
            db.masters.Add(master);
            return "Запись добавлена!";
        }

        public RegistrationResponse Registration(RegistrationRequest registration)
        {
            var result = db.users.Where(p => p.login == registration.login);
            if (result != null)
            {
                return new RegistrationResponse { errMessage = "Пользователь с таким логином уже имеется!", error = true };
            }
            User user = new User { login = registration.login, name = registration.name, surname = registration.surname, password = registration.password };
            db.users.Add(user);
            return new RegistrationResponse { errMessage = "Регистрация прошла успешно!", error = false };
        }
    }
}
