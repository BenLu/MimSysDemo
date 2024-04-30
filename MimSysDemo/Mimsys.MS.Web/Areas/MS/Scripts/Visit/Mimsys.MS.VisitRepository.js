/* Copyright (c) 2024 Mimsys  All rights reserved. */

// Enable the following commented line to enable TypeScript static type checking
// @ts-check

"use strict";

// Ajax call to controller
var mSVisitAjax = {

    /**
     * @name call
     * @description Common function used to invoke ajax calls
     * @namespace mSVisitAjax
     * @public 
     *  
     * @param {string} method The method to invoke
     * @param {object} data The data for the method call
     * @param {Function} callbackMethod The callback that's called on successful ajax post
     */
    call: (method, data, callbackMethod) => {
        var url = sg.utls.url.buildUrl("MS", "Visit", method);
        sg.utls.ajaxPost(url, data, callbackMethod);
    }
};

var mSVisitRepository = {

    /**
     * @name get
     * @description get call
     * @namespace mSVisitRepository
     * @public
     *
     * @param {string} id The key specifier
     * @param {Function} callbackMethod The callback that's called on successful ajax post
     */
    get: (id, callbackMethod) => {
        var data = { 'id': id };
        mSVisitAjax.call("Get", data, callbackMethod);
    },

    /**
     * @name create
     * @description create call
     * @namespace mSVisitRepository
     * @public
     *
     * @param {Function} callbackMethod The callback that's called on successful ajax post
     */
    create: (callbackMethod) => {
        var data = {};
        mSVisitAjax.call("Create", data, callbackMethod);
    },

    /**
     * @name delete
     * @description delete call
     * @namespace mSVisitRepository
     * @public
     *
     * @param {string} id The key specifier
     * @param {Function} callbackMethod The callback that's called on successful ajax post
     */
    delete: (id, callbackMethod) => {
        var data = { 'id': id };
        mSVisitAjax.call("Delete", data, callbackMethod);
    },

    /**
     * @name add
     * @description add call
     * @namespace mSVisitRepository
     * @public
     *
     * @param {object} data The entity data object
     * @param {Function} callbackMethod The callback that's called on successful ajax post
     */
    add: (data, callbackMethod) => {
        mSVisitAjax.call("Add", data, callbackMethod);
    },

    /**
     * @name update
     * @description update call
     * @namespace mSVisitRepository
     * @public
     *
     * @param {object} data The entity data object
     * @param {Function} callbackMethod The callback that's called on successful ajax post
     */
    update: (data, callbackMethod) => {
        mSVisitAjax.call("Save", data, callbackMethod);
    },

    /**
     * @name post
     * @description post call
     * @namespace mSVisitRepository
     * @public
     *
     * @param {Function} callbackMethod The callback that's called on successful ajax post
     */
    post: (callbackMethod) => {
        mSVisitAjax.call("Post", null, callbackMethod);
    }

    // Additional methods go here
};