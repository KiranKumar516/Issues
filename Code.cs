
                StateClient stateClient = activity.GetStateClient();
                BotData userData = stateClient.BotState.GetUserData(activity.ChannelId, activity.From.Id);

                var currentLanguageCode = userData.GetProperty<string>("Username");
