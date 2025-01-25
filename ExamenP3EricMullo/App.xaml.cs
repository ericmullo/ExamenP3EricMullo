using ExamenP3EricMullo.Repositories;

namespace ExamenP3EricMullo
{
    public partial class App : Application
    {
        public static AirportRepository airportRepository { get; private set; }
        public static APIRepository apiRepository { get; private set; }

        public App(AirportRepository AirportRepository, APIRepository APIRepository)
        {
            InitializeComponent();
            airportRepository = AirportRepository;
            apiRepository = APIRepository;
            MainPage = new AppShell();
        }
    }
}
