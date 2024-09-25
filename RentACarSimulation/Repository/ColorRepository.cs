using RentACarSimulation.Models;

namespace RentACarSimulation.Repository;

public class ColorRepository : BaseRepository , IColorRepository
{
    private List<Color> colors;
    
    public List<Color> GetAll()
    {
        return colors;
    }

    public Color? GetById(int id)
    {
        Color? color1 = null;
        foreach (Color color in colors)
        {
            if (color.Id == id)
            {
                color1 = color;
            }
        }

        if (color1 == null)
        {
            return null;
        }

        return color1;
    }

    public Color? Add(Color color)
    {
        colors.Add(color);
        return color;
    }

    public Color? Remove(int id)
    {
        Color? deletedColor = GetById(id);

        if (deletedColor is null)
        {
            return null;
        }
        
        colors.Remove(deletedColor);
        return deletedColor;
    }

    public Color? Update(Color color)
    {
        {
            {

                Color? existingColor = GetById(color.Id);

                if (existingColor is null)
                {
                    return null;
                }

                existingColor.Name = color.Name;
                return existingColor;

            }
        }
    }
}