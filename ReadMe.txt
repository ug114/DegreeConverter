Демонстрационное приложение к статье "Model-View-Controller в .Net" (http://rsdn.ru/?article/?847) и к презентации "Веб-решение или толстый клиент? Сравнение, тенденции, архитектура" (http://www.microsoft.com/Rus/Download.aspx?file=/events/materials/webdevcon06/dev210.ppt), которая была представлена на "WebDevCon'06" (http://www.microsoft.com/rus/events/webdevcon06/default.mspx)

Приложение состоит из трех проектов:
1. DegreeConverter.Engine - содержит класс Модели (Model), класс Презентера (Presenter) и интерфейс для View (IView).
2. DegreeConverter.WinView - проект реализации IView на основе WinForms приложения.
3. DegreeConverter.WebView - проект реализации IView на основе Web приложения.