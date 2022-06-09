# SEA-Models

## Description
This project is a shared kernel which contains the models that are used in the other projects. We have defined the models here in order to avoid code duplication. These models are imported in the other projects by using [submodules](https://git-scm.com/book/en/v2/Git-Tools-Submodules) in git. 

## How to update the models
When you change these models, you also need to update the reference in the projects that use these models in order to get the updates. You do this by running the command:  
```shell
git submodule update --init --recursive --remote
```

