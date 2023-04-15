namespace View
{
    public interface IView
    {
        void ValidateValues(string error);

        void TotalScore(int total);
    }
}