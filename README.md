# Expediteapps
Expediteapps examples

Due to the new controls and possibilities in Windows UAP (Windows 10) Apps and the different 'issues' at the moment I present here several examples on how to implement different controls


<b>ContentDialogBehavior</b>

With this behavior you can add a contentdialog in any control that has the tapped event, you can modify to use in other event, adding a delay or after the end of a storyboard
Is like the implementation of Flyout that does not exist (until now)

```
<i:Interaction.Behaviors>
    <b:ContentDialogBehavior>
      <b:ContentDialogBehavior.ContentDialog>
          <ContentDialog FullSizeDesired="True" Title="New Category"  PrimaryButtonText="Accept" SecondaryButtonText="Cancel" />
      </b:ContentDialogBehavior.ContentDialog>
      <b:ContentDialogBehavior.DataTemplate>
        <DataTemplate>
            <!-- Template -->
        </DataTemplate>
      </b:ContentDialogBehavior.DataTemplate>
    </b:ContentDialogBehavior>
</i:Interaction.Behaviors>
```

<b>EventTriggerBehavior </b>

When the event user is EventName="KeyUp" the parameter that arrives is not the key so to solve you need a simple Converter called EventKeyConverter and the Examaple contains the Command in the ViewModel KeyEventTriggerViewModel.cs



