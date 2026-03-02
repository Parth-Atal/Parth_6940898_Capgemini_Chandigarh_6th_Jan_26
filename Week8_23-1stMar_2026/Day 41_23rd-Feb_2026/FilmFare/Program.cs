namespace FilmFare
{
    public class MovieRatingException : Exception
    {
        public MovieRatingException(string message) : base(message) { }
    }


    public class Rating
    {
        public int imdbRating {  get; set; }
        public int Nominee {  get; set; }

    }

    public class Validator
    {
        public string CanBeConsideredForAward(Rating rr)
        {
            if (rr.imdbRating < 7)
            {
                throw new MovieRatingException("IMDB rating too low");
            }

            if (rr.Nominee < 4)
            {
                throw new MovieRatingException("Nominee count too low");
            }

            return "Movie is eligible for award consideration.";
        }

        public string SendInvite(Rating rr)
        {
            return "Invite sent to the awards ceremony.";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Validator validator = new Validator();

            // Case 1: Valid movie
            try
            {
                Rating r1 = new Rating
                {
                    imdbRating = 8,
                    Nominee = 5
                };

                Console.WriteLine(validator.CanBeConsideredForAward(r1));
            }
            catch (MovieRatingException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            Console.WriteLine();

            // Case 2: Low IMDB rating
            try
            {
                Rating r2 = new Rating
                {
                    imdbRating = 6,
                    Nominee = 5
                };

                Console.WriteLine(validator.CanBeConsideredForAward(r2));
            }
            catch (MovieRatingException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            Console.WriteLine();

            // Case 3: Low Nominee count
            try
            {
                Rating r3 = new Rating
                {
                    imdbRating = 8,
                    Nominee = 2
                };

                Console.WriteLine(validator.CanBeConsideredForAward(r3));
            }
            catch (MovieRatingException ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
