/* Copyright (c) 2024 Mimsys  All rights reserved. */

// Enable the following commented line to enable TypeScript static type checking
// @ts-check

"use strict";

function mSVisitObservableExtension(viewModel, uiMode) {

    let model = viewModel.Data;
    model.UIMode = ko.observable(uiMode);

    // Computed Fields go here
    model.IsVisitDateDisabled = ko.computed(() => {
        // Default to IsReadOnly property in business view
        let isReadOnly = false;
        
        return isReadOnly;
    });

    model.IsVisitCodeDisabled = ko.computed(() => {
        // Default to IsReadOnly property in business view
        let isReadOnly = false;
        
        return isReadOnly;
    });

    model.IsPatientCodeDisabled = ko.computed(() => {
        // Default to IsReadOnly property in business view
        let isReadOnly = false;
        
        return isReadOnly;
    });

    model.IsVisitTypeDisabled = ko.computed(() => {
        // Default to IsReadOnly property in business view
        let isReadOnly = false;
        
        return isReadOnly;
    });


};