
add_executable(strings_unittests strings_unittests.cpp main.c)


target_include_directories(strings_unittests PUBLIC ${TEST_INCLUDES} ${COMMON_SRC})
target_link_libraries (strings_unittests ${CMAKE_THREAD_LIBS_INIT} ctest micromock common)
