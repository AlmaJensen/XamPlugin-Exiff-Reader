You are free to use and modify this plugin however you wish.  I would request if possible to give credit
to Alma Jensen for works used or based off of this project.

This is an Exiff Reader plugin for use with Xamarin.  It does have an issue when being used with James Montemango's 
Media Plugin.  When selecting picutures on iOS there is a cast to uiimage that deletes all exiff data
in iOS.  His plugin though can be modified to return an actual path to a selected image rather than 
a temporary copy that is created when an image is selected.