using RentACarSimulation.Models;

namespace RentACarSimulation.Repository;

public class TransmissionRepository : BaseRepository , ITransmissionRepository
{
    private List<Transmission> transmissions;
    
    public List<Transmission> GetAll()
    {
        return transmissions;
    }

    public Transmission? GetById(int id)
    {
        Transmission? transmission1 = null;
        foreach (Transmission transmission in transmissions)
        {
            if (transmission.Id == id)
            {
                transmission1 = transmission;
            }
        }

        if (transmission1 == null)
        {
            return null;
        }

        return transmission1;
    }

    public Transmission? Add(Transmission transmission)
    {
        transmissions.Add(transmission);
        return transmission;
    }

    public Transmission? Remove(int id)
    {
        Transmission? deletedTransmission = GetById(id);

        if (deletedTransmission is null)
        {
            return null;
        }
        
        transmissions.Remove(deletedTransmission);
        return deletedTransmission;
    }

    public Transmission? Update(Transmission transmission)
    {
        {

            Transmission? existingTransmission = GetById(transmission.Id);

            if (existingTransmission is null)
            {
                return null;
            }

            existingTransmission.Name = transmission.Name;
            return existingTransmission;

        }
    }
}