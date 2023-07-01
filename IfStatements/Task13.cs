namespace IfStatements
{
    public static class Task13
    {
        public static int DoSomething(bool b, int i)
        {
            if (b)
            {
                if (i < -8)
                {
                    return i + 5;
                }

                if (i < -4 && i >= -8)
                {
                    return i;
                }

                if (i >= -4 && i < 0)
                {
                    return 5 + i;
                }

                if (i == 0)
                {
                    return 10;
                }

                if (i > 0 && i <= 3)
                {
                    return i - 5;
                }

                if (i > 3)
                {
                    return i * -1;
                }
            }
            else
            {
                if (i <= -5)
                {
                    return i * -1;
                }

                if (i > -5 && i <= 5)
                {
                    return 10 - i;
                }
            }

            return i * -1;
        }
    }
}
