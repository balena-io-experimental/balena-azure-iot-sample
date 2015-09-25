
add_executable(string_tokenizer_unittests string_tokenizer_unittests.cpp main.c)


target_include_directories(string_tokenizer_unittests PUBLIC ${TEST_INCLUDES} ${COMMON_SRC})
target_link_libraries (string_tokenizer_unittests ${CMAKE_THREAD_LIBS_INIT} ctest micromock common)
