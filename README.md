# HayFigus!
Alertas sobre stock disponible de figuritas del mundial Qatar 2022 en la web de Panini

## Como funciona?
HayFigus es una function de Azure que corre periodicamente. Contiene un web scrapper que chequea la web de Panini Argentina buscando stock en las publicaciones. Las publicaciones son enviadas a un chat de Telegram a traves de un bot para ser consumidas por los subscriptores.

## Configuraciones
**ScrapperUrl**: Url usada por el scrapper para chequear el estado de las publicaciones

**TelegramBotId**: Bot usado para publicar mensajes en el chat.

**TelegramChatId**: Chat donde se publican las alertas de stock disponible. Tiene que ser un canal or grupo para que todo esto tenga sentido.
