/* Copyright (c) 2024 Mimsys  All rights reserved. */

// Enable the following commented line to enable TypeScript static type checking
// @ts-check

"use strict";

let modelData;
var mSVisitUI = mSVisitUI || {};


mSVisitUI = {
    mSVisitModel: {},
    ignoreIsDirtyProperties: ["VisitCode", "IsVisitDateDisabled", "IsVisitCodeDisabled", "IsPatientCodeDisabled", "IsVisitTypeDisabled"],
    computedProperties: ["UIMode"],
    hasKoBindingApplied: false,
    isKendoControlNotInitialised: false,
    visitCode: null,

    /**
     * @name init
     * @description Primary initialization routine
     * @namespace mSVisitUI
     * @public
     */
    init: () => {
        mSVisitUI.initGrids();
        mSVisitUI.initTabs();
        mSVisitUI.initButtons();
        mSVisitUI.initNumericTextboxes();
        mSVisitUI.initTextboxes();
        mSVisitUI.initTimePickers();
        mSVisitUI.initPopUps();
        mSVisitUI.initHamburgers();
        mSVisitUISuccess.initialLoad(VisitViewModel);
        mSVisitUI.initFinders();
        mSVisitUISuccess.setkey();
    },

    /**
     * @name saveMSVisit
     * @description Invoke add or update
     * @namespace mSVisitUI
     * @public
     */
    saveMSVisit: () => {
        if ($("#frmVisit").valid()) {
            let data = sg.utls.ko.toJS(modelData, mSVisitUI.computedProperties);
            if (modelData.UIMode() === sg.utls.OperationMode.SAVE) {
                mSVisitRepository.update(data, mSVisitUISuccess.update);
            } else {
                mSVisitRepository.add(data, mSVisitUISuccess.update);
            }
        }
    },

    /**
     * @name initButtons
     * @description Initialize buttons
     * @namespace mSVisitUI
     * @public
     */
    initButtons: () => {
        // Import/Export Buttons
        sg.exportHelper.setExportEvent("btnOptionExport", "msvisit", false, $.noop);
        sg.importHelper.setImportEvent("btnOptionImport", "msvisit", false, $.noop);

        // Key field blur event
        $("#txtVisitCode").on('blur', (e) => {
            modelData.VisitCode($("#txtVisitCode").val());
            if (sg.controls.GetString(modelData.VisitCode()) !== "") {
                mSVisitUI.checkIsDirty(mSVisitUI.get, mSVisitUI.visitCode);
            }
        });

        // Create New Button
        $("#btnNew").on('click', () => {
            mSVisitUI.checkIsDirty(mSVisitUI.create, mSVisitUI.visitCode);
        });

        // Save Button
        $("#btnSave").on('click', () => {
            sg.utls.SyncExecute(mSVisitUI.saveMSVisit);
        });

        // Delete Button
        $("#btnDelete").on('click', () => {
            if ($("#frmVisit").valid()) {
                let message = jQuery.validator.format(mSVisitResources.DeleteConfirmMessage, mSVisitResources.VisitCodeTitle, modelData.VisitCode());
                sg.utls.showKendoConfirmationDialog(() => {
                    sg.utls.clearValidations("frmVisit");
                    mSVisitRepository.delete(modelData.VisitCode(), mSVisitUISuccess.delete);
                }, null, message, mSVisitResources.DeleteTitle);
            }
        });
    },

    /**
     * @name initDropDownList
     * @description Initialize the drop down list boxes, if any
     * @namespace mSVisitUI
     * @public
     */
    initDropDownList: () => {
        sg.utls.kndoUI.dropDownList("ddlVisitType");

    },

    /**
     * @name initPopUps
     * @description Initialize the various popup windows, if any
     * @namespace mSVisitUI
     * @public
     */
    initPopUps: () => {

    },

    /**
     * @name initHamburgers
     * @description Initialize the hamburger menus, if any
     * @namespace mSVisitUI
     * @public
     */
    initHamburgers: () => {

    },

    /**
     * @name initTabs
     * @description Initialize the tabs, if any
     * @namespace mSVisitUI
     * @public
     */
    initTabs: () => {

    },

    /**
     * @name initGrids
     * @description Initialize the grids, if any
     * @namespace mSVisitUI
     * @public
     */
    initGrids: () => {
        sg.viewList.init('mRDVisitGrid');
        sg.viewList.init('patientPolicyGrid');
    },

    /**
     * @name initFinders
     * @description Initialize the finders, if any
     * @namespace mSVisitUI
     * @public
     */
    initFinders: () => {
    },

    /**
     * @name initNumericTextboxes
     * @description Initialize the Kendo numeric controls, if any
     * @namespace mSVisitUI
     * @public
     */
    initNumericTextboxes: () => {
    },

    /**
     * @name initTextboxes
     * @description Initialize the Kendo text controls, if any
     * @namespace mSVisitUI
     * @public
     */
    initTextboxes: () => {
        $("#txtVisitDate").on('change', (e) => {
            if (sg.utls.kndoUI.checkForValidDate($("#txtVisitDate").val())) {
                sg.utls.clearValidations("frmVisit");
            } else {
                sg.controls.Focus($("#txtVisitDate"));
            }
        });


    },

    /**
     * @name initTimePickers
     * @description Initialize the time pickers, if any
     * @namespace mSVisitUI
     * @public
     */
    initTimePickers: () => {
    },

    /**
     * @name get
     * @description Invoke the get
     * @namespace mSVisitUI
     * @public
     */
    get: () => {
        mSVisitRepository.get(modelData.VisitCode(), mSVisitUISuccess.get);
    },

    /**
     * @name create
     * @description Invoke the create
     * @namespace mSVisitUI
     * @public
     */
    create: () => {
        sg.utls.clearValidations("frmVisit");
        mSVisitRepository.create(mSVisitUISuccess.create);
    },

    /**
     * @name checkIsDirty
     * @description Check to see if the model data has been changed
     * @namespace mSVisitUI
     * @public
     *
     * @param {Function} functionToCall The callback function to invoke
     */
    checkIsDirty: (functionToCall, visitCode) => {
        if (mSVisitUI.mSVisitModel.isModelDirty.isDirty() && visitCode !== null && visitCode !== "") {
            sg.utls.showKendoConfirmationDialog(
                () => { // Yes
                    sg.utls.clearValidations("frmVisit");
                    functionToCall.call();
                },
                () => { // No
                    if (sg.controls.GetString(visitCode) !== sg.controls.GetString(modelData.VisitCode())) {
                        modelData.VisitCode(visitCode);
                   }
                   return;
                },
                jQuery.validator.format(globalResource.SaveConfirm, mSVisitResources.VisitCodeTitle, visitCode));
        } else {
            functionToCall.call();
        }
    }
};

// Callbacks
var mSVisitUISuccess = {

    /**
     * @name setkey
     * @description Set the key
     * @namespace mSVisitUISuccess
     * @public
     */
    setkey: () => {
        mSVisitUI.visitCode = modelData.VisitCode();
    },

    /**
     * @name get
     * @description Event handler for successful get 
     * @namespace mSVisitUISuccess
     * @public
     * 
     * @param {object} jsonResult JSON payload object
     */
    get: (jsonResult) => {
        if (jsonResult.UserMessage && jsonResult.UserMessage.IsSuccess) {
            if (jsonResult.Data !== null) {
                mSVisitUISuccess.displayResult(jsonResult, sg.utls.OperationMode.SAVE);
            } else {
                modelData.UIMode(sg.utls.OperationMode.NEW);
            }
            mSVisitUISuccess.setkey();

            sg.viewList.refresh("mRDVisitGrid");
            sg.viewList.refresh("patientPolicyGrid");

        }
    },

    /**
     * @name update
     * @description Event handler for successful update
     * @namespace mSVisitUISuccess
     * @public
     *
     * @param {object} jsonResult JSON payload object
     */
    update: (jsonResult) => {
        if (jsonResult.UserMessage.IsSuccess) {
            mSVisitUISuccess.displayResult(jsonResult, sg.utls.OperationMode.SAVE);
            mSVisitUISuccess.setkey();
        }
        sg.utls.showMessage(jsonResult);
    },

    /**
     * @name create
     * @description Event handler for successful create
     * @namespace mSVisitUISuccess
     * @public
     *
     * @param {object} jsonResult JSON payload object
     */
    create: (jsonResult) => {
        mSVisitUISuccess.displayResult(jsonResult, sg.utls.OperationMode.NEW);
        mSVisitUI.mSVisitModel.isModelDirty.reset();
        mSVisitUISuccess.setkey();

        sg.controls.Focus($("#txtVisitCode"));
    },

    /**
     * @name delete
     * @description Event handler for successful deletion
     * @namespace mSVisitUISuccess
     * @public
     *
     * @param {object} jsonResult JSON payload object
     */
    delete: (jsonResult) => {
        if (jsonResult.UserMessage.IsSuccess) {
            mSVisitUISuccess.displayResult(jsonResult, sg.utls.OperationMode.NEW);
            mSVisitUI.mSVisitModel.isModelDirty.reset();
            mSVisitUISuccess.setkey();
        }


        sg.utls.showMessage(jsonResult);
    },

    /**
     * @name displayResult
     * @description Display the results of an ajax call
     * @namespace mSVisitUISuccess
     * @public
     *
     * @param {object} jsonResult JSON payload object
     * @param {number} uiMode The UI mode
     */
    displayResult: (jsonResult, uiMode) => {
        if (jsonResult !== null) {
            if (!mSVisitUI.hasKoBindingApplied) {
                mSVisitUI.mSVisitModel = ko.mapping.fromJS(jsonResult);
                mSVisitUI.hasKoBindingApplied = true;
                modelData = mSVisitUI.mSVisitModel.Data;
                mSVisitObservableExtension(mSVisitUI.mSVisitModel, uiMode);
                mSVisitUI.mSVisitModel.isModelDirty = new ko.dirtyFlag(modelData, mSVisitUI.ignoreIsDirtyProperties);
                ko.applyBindings(mSVisitUI.mSVisitModel);
            } else {
                ko.mapping.fromJS(jsonResult, mSVisitUI.mSVisitModel);
                modelData.UIMode(uiMode);
                if (uiMode !== sg.utls.OperationMode.NEW) {
                    mSVisitUI.mSVisitModel.isModelDirty.reset();
                }
            }
            // Grid load data
            $('#mRDVisitGrid').data('kendoGrid').dataSource.read();
            $('#patientPolicyGrid').data('kendoGrid').dataSource.read();


            if (!mSVisitUI.isKendoControlNotInitialised) {
                mSVisitUI.isKendoControlNotInitialised = true;
                mSVisitUI.initDropDownList();
            } else {
                // 
          }
        }
        sg.viewList.refresh("mRDVisitGrid");
        sg.viewList.refresh("patientPolicyGrid");
    },

    /**
     * @name initialLoad
     * @description Called during initial page load
     * @namespace mSVisitUISuccess
     * @public
     *
     * @param {object} result JSON payload object
     */
    initialLoad: (result) => {
        if (result) {
            mSVisitUISuccess.displayResult(result, sg.utls.OperationMode.NEW);
        } else {
            sg.utls.showMessageInfo(sg.utls.msgType.ERROR, mSVisitResources.ProcessFailedMessage);
        }
        sg.controls.Focus($("#txtVisitCode"));
    },

    /**
     * @name isNew
     * @description Determine if we're creating a new entity
     * @namespace mSVisitUISuccess
     * @public
     */
    isNew: (model) => {
        if (model.VisitCode() === null) {
           return true;
        }
        return false;
    }
};

// Utility
var mSVisitUtility = {

};

// Initial Entry
$(() => {
    mSVisitUI.init();
    $(window).on('beforeunload', () => {
        if (globalResource.AllowPageUnloadEvent && mSVisitUI.mSVisitModel.isModelDirty.isDirty()) {
            return jQuery('<div />').html(jQuery.validator.format(globalResource.SaveConfirm2, mSVisitResources.VisitCodeTitle)).text();
        }
    });
    $(window).on('unload', () => {
        sg.utls.destroySession();
    });
});
