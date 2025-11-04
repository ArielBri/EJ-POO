namespace POO_1
{
    public class NotificationService
    {
        // Método que procesa una lista de notificaciones de forma uniforme
        public void SendBatch(List<Notification> notifications)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine("  SERVICIO DE NOTIFIACIONES - Sending Batch");
            Console.WriteLine("===========================================");
            Console.WriteLine($"Total notifications to send: {notifications.Count}\n");

            int count = 1;
            foreach (Notification notification in notifications)
            {
                Console.WriteLine($"[{count}/{notifications.Count}]");
                notification.Send();
                count++;
            }

            Console.WriteLine("=========================================");
            Console.WriteLine("  TODAS LAS NOTIFIACIONES FUERON ENVIADAS");
            Console.WriteLine("=========================================");
        }
    }
}
