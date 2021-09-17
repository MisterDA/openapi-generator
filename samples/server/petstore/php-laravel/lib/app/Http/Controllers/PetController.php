<?php

/**
 * OpenAPI Petstore
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 * PHP version 7.2.5
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI-Generator
 * https://openapi-generator.tech
 * Do not edit the class manually.
 *
 * Source files are located at:
 *
 * > https://github.com/OpenAPITools/openapi-generator/blob/master/modules/openapi-generator/src/main/resources/php-laravel/
 */


namespace App\Http\Controllers;

use Illuminate\Support\Facades\Request;

class PetController extends Controller
{
    /**
     * Constructor
     */
    public function __construct()
    {
    }

    /**
     * Operation uploadFileWithRequiredFile
     *
     * uploads an image (required).
     *
     * @param int $petId ID of pet to update (required)
     *
     * @return Http response
     */
    public function uploadFileWithRequiredFile($petId)
    {
        $input = Request::all();

        //path params validation


        //not path params validation

        return response('How about implementing uploadFileWithRequiredFile as a post method ?');
    }
    /**
     * Operation addPet
     *
     * Add a new pet to the store.
     *
     *
     * @return Http response
     */
    public function addPet()
    {
        $input = Request::all();

        //path params validation


        //not path params validation
        if (!isset($input['pet'])) {
            throw new \InvalidArgumentException('Missing the required parameter $pet when calling addPet');
        }
        $pet = $input['pet'];


        return response('How about implementing addPet as a post method ?');
    }
    /**
     * Operation updatePet
     *
     * Update an existing pet.
     *
     *
     * @return Http response
     */
    public function updatePet()
    {
        $input = Request::all();

        //path params validation


        //not path params validation
        if (!isset($input['pet'])) {
            throw new \InvalidArgumentException('Missing the required parameter $pet when calling updatePet');
        }
        $pet = $input['pet'];


        return response('How about implementing updatePet as a put method ?');
    }
    /**
     * Operation findPetsByStatus
     *
     * Finds Pets by status.
     *
     *
     * @return Http response
     */
    public function findPetsByStatus()
    {
        $input = Request::all();

        //path params validation


        //not path params validation
        if (!isset($input['status'])) {
            throw new \InvalidArgumentException('Missing the required parameter $status when calling findPetsByStatus');
        }
        $status = $input['status'];


        return response('How about implementing findPetsByStatus as a get method ?');
    }
    /**
     * Operation findPetsByTags
     *
     * Finds Pets by tags.
     *
     *
     * @return Http response
     * @deprecated
     */
    public function findPetsByTags()
    {
        $input = Request::all();

        //path params validation


        //not path params validation
        if (!isset($input['tags'])) {
            throw new \InvalidArgumentException('Missing the required parameter $tags when calling findPetsByTags');
        }
        $tags = $input['tags'];


        return response('How about implementing findPetsByTags as a get method ?');
    }
    /**
     * Operation deletePet
     *
     * Deletes a pet.
     *
     * @param int $petId Pet id to delete (required)
     *
     * @return Http response
     */
    public function deletePet($petId)
    {
        $input = Request::all();

        //path params validation


        //not path params validation

        return response('How about implementing deletePet as a delete method ?');
    }
    /**
     * Operation getPetById
     *
     * Find pet by ID.
     *
     * @param int $petId ID of pet to return (required)
     *
     * @return Http response
     */
    public function getPetById($petId)
    {
        $input = Request::all();

        //path params validation


        //not path params validation

        return response('How about implementing getPetById as a get method ?');
    }
    /**
     * Operation updatePetWithForm
     *
     * Updates a pet in the store with form data.
     *
     * @param int $petId ID of pet that needs to be updated (required)
     *
     * @return Http response
     */
    public function updatePetWithForm($petId)
    {
        $input = Request::all();

        //path params validation


        //not path params validation

        return response('How about implementing updatePetWithForm as a post method ?');
    }
    /**
     * Operation uploadFile
     *
     * uploads an image.
     *
     * @param int $petId ID of pet to update (required)
     *
     * @return Http response
     */
    public function uploadFile($petId)
    {
        $input = Request::all();

        //path params validation


        //not path params validation

        return response('How about implementing uploadFile as a post method ?');
    }
}
