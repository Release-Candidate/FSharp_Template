# Contributing

Any help is welcome!

If you encounter a problem using FSHARP_TEMPLATE, a task it not as easy as you'd like it to be or you'd like something added to it: open an issue at GitHub.

## Report Issues (Bugs and Feature Requests)

File a bug report at [Github](https://github.com/Release-Candidate/FSharp_Template/issues/new?assignees=&labels=&template=bug_report.md&title=).
Add a feature request at [Github](https://github.com/Release-Candidate/FSharp_Template/issues/new?assignees=&labels=&template=feature_request.md&title=).
Take a look at the [Issue Tracker at GitHub](https://github.com/Release-Candidate/FSHARP_TEMPLATE/issues)

## Forking the Repository

If you'd like to contribute directly, e.g. better the documentation, add another language or write some source code: fork tzolkin-calendar by clicking the Fork-button in the upper right corner of the GitHub project website. Check out your fork of tzolkin-calendar using the URL from the Code-button of your fork on Github. The URL should be something like github.com/YOUR_USERNAME/tzolkin-calendar.git.

Details about how to fork a repository on Github are here.

## Setting the Development Environment

All needed packages to develop tzolkin-calendar are installed in a virtual environment using pipenv, so your system-wide Python installation isn't affected by it.

First, install pipenv if you don't already have it installed:

python -m pip install --upgrade pipenv
and install all needed packages to develop tzolkin-calender:

cd tzolkin-calendar
python -m pipenv install --dev
That command installs all packages in Pipfile/Pipfile.lock in the directory tzolkin-calender, the root directory of tzolkin-calendar.

More information about pipenv can be found at Pipenv.

Make your changes, push them to your forked repository and make a pull-request (e.g. using the Pull request-button above and right of GitHubs source file view).

See [GitHub on Pull-Requests](https://docs.github.com/en/github/collaborating-with-issues-and-pull-requests/proposing-changes-to-your-work-with-pull-requests)

## Github Documentation on Collaborating with Issues and Pull Requests

See GitHub's documentation about how to contribute for details: Contributing at Github.

## Common Tasks Developing FSHARP_TEMPLATE_

### Jupyter Notebooks

The 3 Jupyter Notebooks are located in the project root directory tzolkin_calendar, named Tzolkin Calendar.ipynb, Tzolkin Command Line.ipynb and Tzolkin Calender Python Module.ipynb

### Changing and Generating Documentation

All files to generate the Mkdocs documentation for Read The Docs are located in the directory tzolkin_calendar/tzolkin_calendar/doc/source.

After that, the new HTML documentation should have been generated in tzolkin_calendar/tzolkin_calendar/doc/html and you can open tzolkin_calendar/tzolkin_calendar/doc/html/index.html in a browser to see it.

#### GitHub Documentation

The Markdown documentation for GitHub are the files README.md and CHANGELOG.md in the project root directory tzolkin_calendar.

### Source Code


### Tests

All test code is located in the directory /tests/.

### GitHub Workflows/Actions
