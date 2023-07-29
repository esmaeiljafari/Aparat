# How to use the bot?

To use the robot services, you can use the following code:

 ``` c#
 AparatBot.api.ApiAparat api = new AparatBot.api.ApiAparat();
```
 If you want to use this bot on the web and as an ioc container, you can use the following code:

  ``` c#
Services.AddScoped<AparatBot.api.IApiAparat,AparatBot.api.ApiAparat>();
```



# User
#### With this [property] you can work with users information:

### GetMediaByUserName
#### By entering the desired username, it gives information about that person
``` c#

 var result=await api.UserProcessor.GetProfile("ali");

````





## Media

#### With this [property] you can work with media :

### GetMediaByUserName
#### To get a user's media and its count
``` c#
var result=await api.MediaProcessor.GetMediaByUserName("gym",1);
````

### GetMediaByVideohash
#### By entering the desired media token, it will give you information about that item
``` c#
//https://www.aparat.com/v/y7MBA
var result=await api.MediaProcessor.GetMediaByVideohash("y7MBA");
````





