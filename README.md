# CsuChhs.Blazor.MarkdownEditor

This is a Markdown Editor for use in blazor forms.  It contains a live preview as well 
as an embeded help guide for users.  

![writing](https://github.com/csu-chhs/CsuChhs.Blazor.MarkdownEditor/blob/main/img/write.jpg?raw=true)

![preview](https://github.com/csu-chhs/CsuChhs.Blazor.MarkdownEditor/blob/main/img/preview.jpg?raw=true)

### Usage

Add the Editor to your ```_Imports.razor```

```
@using CsuChhs.Blazor.MarkdownEditor
```

Inside of an EditForm reference the editor component and bind it.

```
<EditForm OnValidSubmit="DoSave" Model="model">
  <MarkdownEditor @bind-Value="model.Comments"/>
</EditForm>
```

The editor binds the markdown text, not parsed HTML.

The toolbar (work in progress) is added by default.  You can disable
this by passing EnableToolbar="false" into the component.