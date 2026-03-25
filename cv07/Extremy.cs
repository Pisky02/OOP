public static class Extremy
{
    public static T Nejvetsi<T>(T[] pole) where T : IComparable
    {
        if (pole == null || pole.Length == 0) throw new ArgumentException("Pole nesmí být prázdné");
        T max = pole[0];
        foreach (var item in pole)
        {
            if (item.CompareTo(max) > 0) max = item;
        }
        return max;
    }

    public static T Nejmensi<T>(T[] pole) where T : IComparable
    {
        if (pole == null || pole.Length == 0) throw new ArgumentException("Pole nesmí být prázdné");
        T min = pole[0];
        foreach (var item in pole)
        {
            if (item.CompareTo(min) < 0) min = item;
        }
        return min;
    }
}
