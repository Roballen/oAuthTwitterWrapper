#oAuthTwitterWrapper
================================
This provides a really simple solution to authenticating and wrapping twitter's API calls using the 1.1 API.

Currently it exposes timeline (twitter feed) and search calls, returned as raw json.

Screen shot below (please note there is no styling applied you have full control over how it is rendered in your application).


![Demo MVC Web App output](./ScreenShot.PNG "Demo MVC Web App output")

The idea stems from this question on Stackoverflow:
[http://stackoverflow.com/questions/17067996/authenticate-and-request-a-users-timeline-with-twitter-api-1-1-oauth](http://stackoverflow.com/questions/17067996/authenticate-and-request-a-users-timeline-with-twitter-api-1-1-oauth)

If you like this and use it please upvote my question and answer.

## General instructions
You need to get your consumer key and secret from [https://dev.twitter.com/apps/new] (https://dev.twitter.com/apps/new).
You can add them to the config files in each project (app.config and web.config). You will also have to set the screenname too.

## Console
This is the simplest form of use, it just makes the call and prints to the console window.
## Web application 
This uses a page WebMethod to make the api call and an Ajax json request to display the tweets.
It could however be exposed in any kind of web service.
It makes use of jQuery and this great library [twitter-text] (https://github.com/twitter/twitter-text-js).
## Mvc application 
This uses a controller action that returns the json and uses the same method to display them as above.
Again this uses jQuery and twitter-text. * Please note that I created this in VS2010 and you need MVC4 installed, I will update this to VS2012 soon.
## Umbraco razor solution 
(todo: tested just need to add to project)
