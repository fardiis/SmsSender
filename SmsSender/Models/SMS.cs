using Kavenegar;

namespace SmsSender.Models
{
    public class SMS
    {
        public void Send(string To, string Body)
        {
            var sender = /*"10004346"*/"1000596446";
            var receptor = To;
            var message = Body;
            var api = new KavenegarApi("716A7348334570657648646C6448423067565353796349516253783144686A2B4E516B63466351536758633D");
            api.Send(sender, receptor, message);
        }
    }
}
