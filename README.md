# HayFigus!
Alertas sobre stock de figuritas de Qatar 2022 disponible en la web de Panini

## Como funciona?
HayFigus es una function de Azure que corre cada 30 segundos. Contiene un web scrapper que chequea la web de Panini Argentina buscando stock en las publicaciones. Las publicaciones son enviadas a un canal de Telegram a traves de un bot para ser consumidas por los subscriptores.

## Configuraciones
**ScrapperUrl**: Url usada por el scrapper para chequear el estado de las publicaciones

**TelegramBotId**: Bot usado para publicar mensajes en el canal

**TelegramChatId**: Canal donde se publican las alertas de stock disponible
