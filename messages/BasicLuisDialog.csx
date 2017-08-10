using System;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Azure;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;

// For more information about this template visit http://aka.ms/azurebots-csharp-luis
[Serializable]
public class BasicLuisDialog : LuisDialog<object>
{
    public BasicLuisDialog() : base(new LuisService(new LuisModelAttribute(Utils.GetAppSetting("LuisAppId"), Utils.GetAppSetting("LuisAPIKey"))))
    {
    }

    [LuisIntent("None")]
    public async Task NoneIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the none intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }

    // Go to https://luis.ai and create a new intent, then train/publish your luis app.
    // Finally replace "MyIntent" with the name of your newly created intent in the following handler
    [LuisIntent("MyIntent")]
    public async Task MyIntent(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"You have reached the MyIntent intent. You said: {result.Query}"); //
        context.Wait(MessageReceived);
    }
    
        [LuisIntent("Conhecimentos")]
    public async Task Conhecimentos(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Tenho conhecimentos em C#, Asp.NET e bla bla bla"); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Experiências")]
    public async Task Experiências(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Já trabalhei na aec, ativas e cobrar."); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Idade")]
    public async Task Idade(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Tenho 29 anos."); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Nome_Completo")]
    public async Task Nome_Completo(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Meu nome completo é Vitor Hugo de Almeida Profeta."); //
        context.Wait(MessageReceived);
    }

    [LuisIntent("Formacao")]
    public async Task Formacao(IDialogContext context, LuisResult result)
    {
        await context.PostAsync($"Formei no Cefet-MG em Engenharia de Computação."); //
        context.Wait(MessageReceived);
    }

}