using Groups.Implementions;
using Clients.Implementations;
namespace Groups
{
class Program {
        static void Main(string[] args) {
            var client1 = new ClientEntity { Id = 1, Name = "Mary", ClientId = "C1" };
            var client2 = new ClientEntity { Id = 2, Name = "Stive", ClientId = "C2" };
            
            var trainer = new TrainerEntity { Id = 1, Name = "Mrs. Klinson", TrainerId = "T001" };
            
            var group = new GroupEntity { Id = 1, Name = "Stretching" };
            group.AddClient(client1);
            group.AddClient(client2);
            group.AssignTrainer(trainer);

            group.DisplayGroupInfo();
        }
    }
}
