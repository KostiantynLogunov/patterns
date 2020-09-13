namespace PatternEventChannel
{
    public class EventChannelJob
    {
        public void run()
        {
            var newsChannel = new EventChannel();

            //поставщики новостей
            //де 1й парам. канал куда поставляють новости
            var highgardenGroup = new Publisher("highgarden-news", newsChannel);
            var winterfellNews = new Publisher("winterfell-news", newsChannel);
            var winterfellDaily = new Publisher("winterfell-news", newsChannel);

            //подпищики
            var sansa = new Subscriber("Sansa stark");
            var arya = new Subscriber("Arya Stark");
            var cersei = new Subscriber("Cersei Lannister");
            var snow = new Subscriber("Jon Snow");

            //подпищики подписываются что кому интересно
            newsChannel.subscribe("highgarden-newsk", cersei);
            newsChannel.subscribe("winterfell-news", sansa);
            
            newsChannel.subscribe("highgarden-news", arya);
            newsChannel.subscribe("winterfell-news", arya);
            
            newsChannel.subscribe("winterfell-news", snow);

            //newsChannel принимает посты и передает посты подпищикам относитель того хто на чо подписан
            highgardenGroup.piblish("NEW highgarden post");
            winterfellNews.piblish("NEW winterfell post");
            winterfellDaily.piblish("NEW alternative  winterfell post");
        }
    }
}
